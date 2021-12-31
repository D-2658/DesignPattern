using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.TemplateMethod
{
	public abstract class AbstractClass
	{
		public abstract void Hello();

		public abstract void World();

		/// <summary>
		/// ここがTemplateMethodで重要なメソッド
		/// ロジックを共有し、メソッドの処理をサブクラスで実装している。
		/// </summary>
		public void Greetings()
		{
			this.Hello();
			this.World();
		}
	}
}
