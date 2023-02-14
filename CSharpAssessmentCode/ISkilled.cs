using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientation
{
    public interface ISkilled
    {
        List<string> GetExpertSkills();
        List<string> GetBeginnerSkills();
        void StudySkill(string skill);
    }
}
