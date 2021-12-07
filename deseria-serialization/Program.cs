using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    [Serializable]
    class Tutorial
    {
        public int ID_Player;
        public String Name;

        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID_Player = 1;
            obj.Name = "successs";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Users\NINDYASAFF\Documents\deserialization-serialization\deseria-serialization\DataNama.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"C:\Users\NINDYASAFF\Documents\deserialization-serialization\deseria-serialization\DataNama.txt", FileMode.Open, FileAccess.Read);
            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID_Player);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();
        }
    }
}
