using Composite.Composites;

var input01 = new InputText("input01name", "input01value");
var input02 = new InputText("input02name", "input02value");
var form0 = new Form("form0");

form0.AddComponent(input01);
form0.AddComponent(input02);

var label11 = new LabelText("latex11value");
var input11 = new InputText("input11name", "input11value");


var form1 = new Form("form1");

form1.AddComponent(label11);
form1.AddComponent(input11);
form1.AddComponent(form0);

Console.Write(form1.ConvertToString());


