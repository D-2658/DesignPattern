using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Builder
{
	public class Director
	{
		private Builder builder;
		public Director(Builder builder)
		{
			this.builder = builder;
		}

		public void Construct()
		{
			this.builder.SetID(0);
			this.builder.SetName("ビルダー君");
			this.builder.SetAge(20);
		}
	}
}
