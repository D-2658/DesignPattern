using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Adapter
{
	public class Client
	{
		/// <summary>
		/// Client Adapteeクラスを使いたいクラス。
		/// </summary>
		public void Start()
		{
			var instance = new Adaptee();
			Target target = new Adapter(instance);

			target.ExecuteComplicatedMethod();
			target.ExecuteShowMassage("こんにちは、");
		}
	}
}
