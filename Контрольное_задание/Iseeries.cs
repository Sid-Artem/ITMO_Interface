using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольное_задание
{
    interface Iseeries
    {
        void setStart(int x);
        int getNext();
        void reset();

    }
    class ArifmeticProgresoion : Iseeries
    {
        int step;
        int currentvalue;
        int startvalue;

        public int getNext()
        {
            currentvalue+=step;
            return currentvalue;
        }

        public void reset()
        {
            currentvalue=startvalue;
        }

        public void setStart(int x)
        {
            startvalue=x;
            currentvalue=startvalue;
        }
        public void setStep(int s)
        {
            step=s;
        }
    }
    class GeometricProgresoion : Iseeries
    {
        int step;
        int currentvalue;
        int startvalue;

        public int getNext()
        {
            currentvalue *= step;
            return currentvalue;
        }

        public void reset()
        {
            currentvalue = startvalue;
        }

        public void setStart(int x)
        {
            startvalue = x;
            currentvalue = startvalue;
        }
        public void setStep(int s)
        {
            step = s;
        }
    }
}
