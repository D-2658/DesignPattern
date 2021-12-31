using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.FactoryMethod
{
	/// <summary>
	/// ファクトリークラスの実装
	/// </summary>
	public class SnackFactory : Factory
	{
		/// <summary>
		/// 生成したスナックのリスト
		/// </summary>
		private List<Product> SnackList = new List<Product>();

		/// <summary>
		/// スナックの生成の実装
		/// </summary>
		/// <param name="taste"></param>
		/// <returns></returns>
		protected override Product CreateProduct(string taste)
		{
			return new Jagarico(taste);
		}

		/// <summary>
		/// スナックの登録の実装
		/// </summary>
		/// <param name="product"></param>
		protected override void RegisterProduct(Product product)
		{
			this.SnackList.Add(product);
		}
	}
}
