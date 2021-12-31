using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSample.Builder;
using DesignPatternSample.FactoryMethod;
using DesignPatternSample.ProtoType;
using DesignPatternSample.TemplateMethod;

namespace DesignPatternSample
{
	class Program
	{
		static void Main(string[] args)
		{
			Adapter();
			TemplateMethod();
			Bridge();
			FactoryMethod();
			ProtoType();
			Builder();

			Console.WriteLine("終了するには何か入力してください...");
			Console.ReadKey();
		}

		/// <summary>
		/// クラス間をにインターフェイスを設けることで仕様の違いを吸収したり結合を緩くする。
		/// 既存のインターフェイス、機能を新たな仕組みに適合させたいとき。改造時に使える。
		/// </summary>
		static void Adapter()
		{
			Console.WriteLine("Adapter");

			Adapter.Client client = new Adapter.Client();
			client.Start();

			Console.WriteLine();
		}

		/// <summary>
		/// スーパークラスではロジックのみを定義し、サブクラスでメソッドを実装する。	
		/// </summary>
		static void TemplateMethod()
		{
			Console.WriteLine("TemplateMethod");

			AbstractClass abstractClass = new ConcreteClass();
			AbstractClass abstractClass_en = new ConcreteClass_en();
			abstractClass.Greetings();
			abstractClass_en.Greetings();

			Console.WriteLine();
		}

		/// <summary>
		/// 抽象と実装を別々の階層に分ける。
		/// それぞれを独立して開発でき、実装にバリエーションを持たせることもできる。(例えばOS毎に実装を行ったりだとか)
		/// </summary>
		static void Bridge()
		{
			Console.WriteLine("Bridge");

			Cooking cooking_1 = new Cooking(new ConcreteCookingImp());
			cooking_1.FriedRice();

			Cooking cooking_2 = new ExtendCooking(new ConcreteCookingImp());
			cooking_2.FriedRice();

			ExtendCooking cooking_3 = new ExtendCooking(new ConcreteCookingImp());
			cooking_3.VegetableStick();

			Console.WriteLine();
		}


		/// <summary>
		///	TemplateMethodの様な機能と実装の分離をインスタンスの生成に用いる方法
		///	結合が疎になるためユニットテストが行ないやすくなる。
		///	インスタンスの生成方法が変わっただけに見えるが、クラス名に依存しないつくりを実現できるので設計の段階では有用
		/// </summary>
		static void FactoryMethod()
		{
			Console.WriteLine("FactoryMethod");

			Factory factory = new SnackFactory();
			Product product1 = factory.Create("のりしお");
			Product product2 = factory.Create("コンソメ");
			Product product3 = factory.Create("うすしお");
			product2.Eat();

			Console.WriteLine();
		}

		/// <summary>
		/// インスタンス生成が難しいクラス、細かい差分が多いクラスを生成するときに複製する方法を用いる。
		/// クラス名をソース内に書く必要がなく、余計なクラスとファイルを作らずに済む。
		/// </summary>
		static void ProtoType()
		{
			Console.WriteLine("ProtoType");

			// インスタンスの準備
			Manager manager = new Manager();
			ConcretePrototyoe complexInstance1 = new ConcretePrototyoe();
			complexInstance1.Status = 1;
			ConcretePrototyoe complexInstance2 = new ConcretePrototyoe();
			complexInstance2.Status = 2;
			manager.Redister("Status1", complexInstance1);
			manager.Redister("Status2", complexInstance2);

			// 生成が難しいインスタンスを複製する時に利用する。Status以外に大量にプロパティがある場合など。
			// Createメソッドは事前に準備したインスタンスのクローンを渡す。
			// 文字列でインスタンスを指定することでクラス名の制約からも解放できる。
			ConcretePrototyoe clone1 =  (ConcretePrototyoe)manager.Create("Status1");
			clone1.GetStatus();
			ConcretePrototyoe clone2 = (ConcretePrototyoe)manager.Create("Status2");
			clone2.GetStatus();

			Console.WriteLine();
		}

		/// <summary>
		/// コンストラクターで複数の値を設定する必要がある場合に用いられる。
		/// コンストラクタで引数が多くなってしまう場合に有効らしい。
		/// この例では一つの情報をIDカードと手配書の二種類の表現をしている。
		/// </summary>
		static void Builder()
		{
			Console.WriteLine("Builder");

			// IDカード
			IDBuilder idBuilder = new IDBuilder();
			Director hgDirector = new Director(idBuilder);
			hgDirector.Construct();
			idBuilder.GetResult();

			// 手配書
			WantedBuilder wantedBuilder = new WantedBuilder();
			Director fgDirector = new Director(wantedBuilder);
			fgDirector.Construct();
			wantedBuilder.GetResult();

			Console.WriteLine();
		}
	}
}
