using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication {
	public class SerializableObject {
		public void save() {
			var type = GetType();

			var serializer = new XmlSerializer(type);
			var fileStream = new FileStream($"{type.Name}.xml", FileMode.Create);
			var streamWriter = new StreamWriter(fileStream);

			serializer.Serialize(streamWriter, this);
			streamWriter.Close();
			fileStream.Close();
		}

		public object load() {
			var type = GetType();
			var serializer = new XmlSerializer(type);
			var fileStream = new FileStream($"{type.Name}.xml", FileMode.Open);
			var streamReader = new StreamReader(fileStream);
			var obj = serializer.Deserialize(streamReader);
			streamReader.Close();
			fileStream.Close();
			return obj;
		}
	}
}
