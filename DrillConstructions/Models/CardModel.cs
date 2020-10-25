using System.Collections.Generic;

namespace DrillConstructions.Models
{
		public class CardModel
		{

				public KeyValuePair<string, string> Construction { get; set; }
				public KeyValuePair<string, string> Meaning { get; set; }
				public KeyValuePair<string, string> Example { get; set; }
				public KeyValuePair<string, string> Type { get; set; }
				public KeyValuePair<string, string> ID { get; set; }

				public CardModel(string constructionToAdd, string meaningToAdd, string exampleToAdd, string TypeToAdd)
				{
						Construction = new KeyValuePair<string, string>("@construction", constructionToAdd);
						Meaning = new KeyValuePair<string, string>("@meaning", meaningToAdd);
						Example = new KeyValuePair<string, string>("@example", exampleToAdd);
						Type = new KeyValuePair<string, string>("@type", TypeToAdd);
				}

				public CardModel(string constructionToAdd, string meaningToAdd, string exampleToAdd, string TypeToAdd, string id)
				{
						ID = new KeyValuePair<string, string>("@id", id);
						Construction = new KeyValuePair<string, string>("@construction", constructionToAdd);
						Meaning = new KeyValuePair<string, string>("@meaning", meaningToAdd);
						Example = new KeyValuePair<string, string>("@example", exampleToAdd);
						Type = new KeyValuePair<string, string>("@type", TypeToAdd);
				}

				public CardModel(string id)
				{
						ID = new KeyValuePair<string, string>("@id", id);
				}

		}
}
