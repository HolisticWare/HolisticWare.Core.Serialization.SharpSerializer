using System;
using System.Collections.Generic;
using System.Text;


using System.IO;

namespace HelloWorldApp.BusinessObjects
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="http://www.sharpserializer.com/en/tutorial/index.html"/>
	public partial class ControllerPersonOperations
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="person"></param>
		public static void SerializeSharpSerializerBinary(Person p)
		{
			// create instance of sharpSerializer
			// true - binary serialization, false - xml serialization
			var serializer = new HolisticWare.Core.Serialization.SharpSerializer.SharpSerializer(true);

            // serialize
            serializer.Serialize
                        (
                            p,
                            new FileStream
                                    (
                                        Path.Combine(path_root, "Person.SharpSerializer.bin"), 
                                        FileMode.OpenOrCreate,
                                        FileAccess.ReadWrite
                                    )
                        );

			return;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="person"></param>
		public static void SerializeSharpSerializerXml(Person p)
		{
			// create instance of sharpSerializer
			// true - binary serialization, false - xml serialization
			var serializer = new HolisticWare.Core.Serialization.SharpSerializer.SharpSerializer(false);

			// serialize
			serializer.Serialize
                      (
                            p,
                            new FileStream
                                    (
                                        Path.Combine(path_root, "Person.SharpSerializer.xml"),
                                        FileMode.OpenOrCreate,
                                        FileAccess.ReadWrite
                                    )
                        );

			return;
		}


		public static Person DeserializeSharpSerializerBinary()
		{
			Person p = default(Person);

			// create instance of sharpSerializer
			// true - binary serialization, false - xml serialization
			var serializer = new HolisticWare.Core.Serialization.SharpSerializer.SharpSerializer(true);

			// deserialize
			p = (Person) serializer.Deserialize
                                        (
                                            new FileStream
                                                (
                                                    Path.Combine(path_root, "Person.SharpSerializer.bin"),
                                                    FileMode.OpenOrCreate,
                                                    FileAccess.ReadWrite
                                                )
                                        );

			return p;
		}

		public static Person DeserializeSharpSerializerXml()
		{
			Person p = default(Person);

			// create instance of sharpSerializer
			// true - binary serialization, false - xml serialization
			var serializer = new HolisticWare.Core.Serialization.SharpSerializer.SharpSerializer(false);

			// deserialize
			p = (Person)serializer.Deserialize
                                    (
                                       new FileStream
                                                (
                                                    Path.Combine(path_root, "Person.SharpSerializer.xml"),
                                                    FileMode.OpenOrCreate,
                                                    FileAccess.ReadWrite
                                                )
                                   );

			return p;
		}
	}
}
