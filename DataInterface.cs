using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace elytica_c_sharp_diet_app
{
  public class FoodItem
  {
    [JsonProperty("Name")]
    public string Name { get; set; }

    [JsonProperty("Unit Cost (EUR/g)")]
    public double UnitCost { get; set; }

    [JsonProperty("Unit Portion (g)")]
    public double UnitPortion { get; set; }

    [JsonProperty("Calories (kcal)")]
    public double Calories { get; set; }

    [JsonProperty("Fat (g)")]
    public double Fat { get; set; }

    [JsonProperty("Carbohydrates (g)")]
    public double Carbohydrates { get; set; }

    [JsonProperty("Protein (g)")]
    public double Protein { get; set; }

    [JsonProperty("Calcium (mg)")]
    public double Calcium { get; set; }

    [JsonProperty("Potassium (mg)")]
    public double Potassium { get; set; }

    [JsonProperty("Vitamin A (mg)")]
    public double VitaminA { get; set; }

    [JsonProperty("Vitamin B6 (mg)")]
    public double VitaminB6 { get; set; }
  }

  public class Nutrient
  {
    public string Name { get; set; }
    public double Minimum { get; set; }
    public double Maximum { get; set; }
  }

  public class DietProblem
  {
    public FoodItem[] Food { get; set; }
    public Nutrient[] Nutrients { get; set; }
  }

  public class ResultItem
  {
    public string Food { get; set; }
    public double Portions { get; set; }
  }

  public class DietResult
  {
    public ResultItem[] Diet { get; set; }
  }

  internal class DataInterface
  {
    public DietProblem input_data { get; set; }
    public DietResult result_data { get; set; }
    public void ParseJsonInputString(string json_str)
    {
      input_data = JsonConvert.DeserializeObject<DietProblem>(json_str);
    }
    public void ParseJsonResultString(string json_str)
    {
      result_data = JsonConvert.DeserializeObject<DietResult>(json_str);
    }
    public string GetDataJsonString()
    {
      return JsonConvert.SerializeObject(input_data, Formatting.Indented);      
    }
  }
}
