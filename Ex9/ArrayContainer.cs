using System;
using Ex9.Identity;

namespace Ex6V10
{
    class ArrayContainer
    {
        private int _count;
        private IHuman[] _humen;

        public ArrayContainer()
        {
            _humen = new IHuman[10];
            _count = 0;
        }

        public bool Add(IHuman printer)
        {
            if (_count >= 10)
            {
                return false;
            }

            for (int i = 0; i < _humen.Length; i++)
            {
                if (_humen[i] == null)
                {
                    _humen[i] = printer;
                    break;
                }
            }
            _count++;
            return true;
        }

        public bool Delete(IHuman printer)
        {
            if (_count < 1)
            {
                return false;
            }

            for (int i = 0; i < _humen.Length; i++)
            {
                if (_humen[i] == printer)
                {
                    _humen[i] = null;
                    break;
                }
            }
            _count--;
            return true;
        }

        public IHuman Search(IHuman humen)
        {
            if (_count < 1)
            {
                return null;
            }

            for (int i = 0; i < _humen.Length; i++)
            {
                if (_humen[i].Lastname == humen.Lastname)
                {
                    return _humen[i];
                }
            }
            return null;
        }

        public void Out()
        {
            if (_count < 1)
            {
                return;
            }

            for (int i = 0; i < _humen.Length; i++)
            {
                if (_humen[i] == null)
                {
                    break;
                }

                Console.WriteLine(_humen[i].Lastname);
            }
        }
    }
}
