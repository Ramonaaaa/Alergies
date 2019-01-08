using System;
using System.Collections.Generic;
using System.Text;

namespace Alergies_OOP
{
    class Alergy
    {
        public enum Alergies
        {
            Eggs,
            Peanuts,
            Shellfish,
            Strawberries,
            Tomatoes,
            Chocolate,
            Pollen,
            Cats
        }

        private readonly string name;
        private int score;

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                if (value >= 0)
                {
                    this.score = value % 256;
                }
                else this.score = 0;
                
            }
        }


        public Alergy(string name)
        {
            this.name = name;
        }

        public Alergy(string name, int score)
        {
            this.name = name;
            this.Score = score;
        }

        public string ListAlergy()
        {
            if(score == 0)
            {
                return  Name + " doesn't have any alergy.";
            }
            else
            {
                int code = (int)Math.Pow(2, 7);
                int myScore = this.score;
                string output = "";

                for(var i = 7; i >= 0; i--)
                {
                    if (myScore >= code)
                    {
                        output += " " + ((Alergies)i).ToString();
                        myScore = myScore - code;
                    }

                    code = code / 2;
                }

                return Name + " have the following alergies:" + output;
            }
        }

        public void AddAlergy(Alergies alergie)
        {
            if (this.TestAlergy(alergie))
            {
                Console.WriteLine("The patient already have this alergy.");
            }
            else
            {
                int numarAlergie = (int)alergie;
                int codulAlergieiCurente = (int)Math.Pow(2, numarAlergie);

                score = score + codulAlergieiCurente;
            }
        }

        public bool TestAlergy(Alergies alergie)
        {
            int numarAlergie = (int)alergie;
            int codAlergie = (int)Math.Pow(2, numarAlergie);
                      
            if (score < codAlergie)
            {
                return false;
            }
            else
            {
                string binary = Convert.ToString(score, 2);

                if (binary[binary.Length - (numarAlergie + 1)] == '1')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        
    }
}
