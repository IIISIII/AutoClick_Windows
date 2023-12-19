using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClick
{
    internal class AutoClickInput
    {
        public static int TYPE_MOUSE = 0;
        public static int TYPE_KEYBOARD = 1;

        public static int ACTION_LEFT_CLICK = 0;
        public static int ACTION_RIGHT_CLICK = 1;

        // 0 - mouse / 1 - keyboard
        private int inputType = 0;
        private Point inputPoint;
        private int mouseInput;
        private List<KeyGroup> keyGroups = new List<KeyGroup>();
        private int delay = 0;

        //mouse
        public AutoClickInput(Point point, int mouseInput, int delay)
        { 
            this.inputType = 0;
            this.inputPoint = point;
            this.mouseInput = mouseInput;
            this.delay = delay;
        }

        //keyboard
        public AutoClickInput(List<KeyGroup> keyGroups, int delay)
        {
            this.inputType = 1;
            this.keyGroups = keyGroups;
            this.delay = delay;
        }

        public int getInputType()
        {
            return this.inputType;
        }

        public Point getInputPoint()
        {
            return this.inputPoint;
        }

        public int getMouseInput()
        {
            return this.mouseInput;
        }

        public List<KeyGroup> getKeyGroups()
        {
            return this.keyGroups;
        }

        public int getDelay()
        {
            return this.delay;
        }
    }
}
