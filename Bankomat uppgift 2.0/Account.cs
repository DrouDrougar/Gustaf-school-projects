
using System.Xml.Linq;

namespace Bankomat_uppgift
{
    public class Account
    {
       
        public string Name { get; set; }

        public int Sum { get; set; }

        //an override to see the objects placed out correctly
        public override string ToString()
        {
            return $"Account holder: {Name} - Account Balance: {Sum}";
        }
    }
}
