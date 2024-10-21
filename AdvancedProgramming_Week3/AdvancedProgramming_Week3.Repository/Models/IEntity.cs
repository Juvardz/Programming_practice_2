using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming_Week3.Repository
{
    public interface IEntity
    {
        int ID { get; set; }
        string Name { get; set; }
    }
}
