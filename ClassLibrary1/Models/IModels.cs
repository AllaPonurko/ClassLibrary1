using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    
        public interface IModel
        {
            public string FileName { get; set; }
            public void Load();
            public void Save();
        }
   
}
