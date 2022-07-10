using System;
namespace PhoneAnalyze.Models
{
    public class PhoneViewModel
    {
        public int PhoneId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string OS { get; set; }
        public int RAM { get; set; }
        public int GPU { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            return $"{PhoneId} {Name}: {Price} {OS} {RAM} {GPU}: {Color}";
        }
    }
}
