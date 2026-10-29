using System.Collections.Specialized;

namespace GenerischeSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IList<T> oder List<T> 

            List<string> list = new List<string>();

            list.Add("Ich");
            list.Add("hoffe");
            list.Add("der");
            list.Add("Kurs");
            list.Add("ist");
            list.Add("super");

            foreach (string item in list) {
                Console.WriteLine(item);
            }

            #endregion

            #region Dictionary
            IDictionary<int, Person> autoNummerschilderRegister = new Dictionary<int, Person>();

            autoNummerschilderRegister.Add(1000, new Person("Otto", "Walkes"));

            //Wenn 1000 noch nicht gibt, dann verwende 1000
            if (!autoNummerschilderRegister.ContainsKey(1000))
            {
                autoNummerschilderRegister.Add(1000, new Person("Harry", "Weinfurth"));
            }

            if (!autoNummerschilderRegister.ContainsKey(1001))
            {
                autoNummerschilderRegister.Add(1001, new Person("Harry", "Weinfurth"));
            }

            foreach (KeyValuePair<int, Person> currentDictionryEintrag in autoNummerschilderRegister)
            {
                Console.WriteLine($"{currentDictionryEintrag.Key} - {currentDictionryEintrag.Value.Vorname} {currentDictionryEintrag.Value.Nachname} ");
            }



            #endregion
        }
    }


    //was ist ein Record (ist eine klasse in komprimierter dargestellter Form) 
    public record Person(string Vorname, string Nachname);
}
