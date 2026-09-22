// Copyright(c) 2024 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: contact@monambike.com for more information.
// For license information, please see the LICENSE file in the root directory.

namespace Monambike.Web.Entities
{
    public class Tip
    {
        private readonly List<string> _phrases;

        public Tip(List<string> phrases)
        {
            _phrases = phrases;
        }

        public string GetRandomTip() => _phrases[new Random().Next(_phrases.Count)];
    }
}
