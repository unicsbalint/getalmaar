using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class SingletonClass
    {
        private SingletonClass() {}
        private static SingletonClass instance;
        public int counter = 0;

        public static SingletonClass GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonClass();
            }
            return instance;
        }
    }
}
