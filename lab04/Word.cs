using System;

namespace lab04
{
    public class Word
    {
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(params string[] translations)
        {
            Translations = translations;

            Random rnd = new Random();
            var from = rnd.Next(translations.Length);
            var to = rnd.Next(translations.Length);
            while (to == from) to = rnd.Next(translations.Length);

            FromLanguage = from;
            ToLanguage = to;

        }

        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
            Translations = translations;
        }
    }
}
