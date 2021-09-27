using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class carte
    {
        private string type;
        private int value;
		private string text;

        public carte(string type, int value ,string text)
        {
            this.type = type;
            this.value = value;
			this.text = text;
        }

		public String getType()
		{
			return type;
		}
		public void setType(String type)
		{
			this.type = type;
		}
		public int getValue()
		{
			return value;
		}
		public void setValue(int value)
		{
			this.value = value;
		}

		public String getText()
		{
			return text;
		}
		
	}
}
