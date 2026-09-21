// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: contact@monambike.com for more information.
// For license information, please see the LICENSE file in the root directory.

namespace Monambike.Web.Models
{
    public class Phrase
    {
        private readonly List<string> _phrases;

        public Phrase(List<string> phrases)
        {
            _phrases = phrases;
        }

        public string GetRandomPhrase() => _phrases[new Random().Next(_phrases.Count)];
    }
}
