using System;
using System.Linq;
using System.ComponentModel;
using InventoryManager.Data;
using Newtonsoft.Json;
using System.IO;

namespace ZorkBuilder.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public BindingList<Player> Players { get; set; }
        public BindingList<Item> Rooms { get; set; }
        public string Filename { get; set; }
        private World _World;
        public World World 
        {
            set
            {
                if (_World != value)
                {
                    _World = value;

                    if (_World != null)
                    {
                        Players = new BindingList<Player>(_World.Players);
                        Rooms = new BindingList<Item>(_World.Rooms);
                    }
                    else
                    {
                        Players = new BindingList<Player>(Array.Empty<Player>());
                        Rooms = new BindingList<Item>(Array.Empty<Item>());
                    }
                }
            }
        }

        public WorldViewModel(World world = null)
        {
            World = world;
        }

        public void SaveGame()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _World);   
            }
        }

        public void CreateGame()
        {
            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            _World = new World();

            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _World);
            }
        }
    }
}