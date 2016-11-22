using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Asteroid : ICloneable
    {
        public Asteroid()
        {
            var form = CreateAsteroidForm();
            var texture = GetTexture();

            form.SetTexture(texture);
        }

        private ObjectForm CreateAsteroidForm()
        {
            Thread.Sleep(10);
            return new ObjectForm();
        }

        private object GetTexture()
        {
            Thread.Sleep(10);
            return new object();
        }

        private void SetTexture(object texture)
        {
            Thread.Sleep(10);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
