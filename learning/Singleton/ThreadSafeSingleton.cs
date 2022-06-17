using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    class ThreadSafeSingleton
    {
        private static readonly ThreadSafeSingleton instance = new ThreadSafeSingleton();
        private ThreadSafeSingleton() {}

        static ThreadSafeSingleton() { }
        public static ThreadSafeSingleton Instance { get { return instance; } }
    }
}
