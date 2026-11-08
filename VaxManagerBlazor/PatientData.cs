using System.Text.Json.Serialization;

namespace VaxManagerBlazor
{
	public class PatientData
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }
		[JsonPropertyName("firstName")]
		public string Firstname { get; set; }
		[JsonPropertyName("lirstName")]
		public string Lastname { get; set; }
		[JsonPropertyName("location")]
		public string Location { get; set; }
		[JsonPropertyName("city")]
		public string City { get; set; }
	}
}
