namespace PythonSandbox;

public class HelloWorld : PythonAutomation
{
    protected override Dependencies Dependencies => Dependencies.None;

	protected override void ApplyAutomation()
	{
		if(Items.Count > 0)
		{
			string name = Items[0, "name"];
			CodeAfterAutomation += @$"
print(""Hello World! Welcome {name} to Arctic Fox"")";
		}
		else
		{ 
			CodeAfterAutomation += @$"
print(""Hello World!"")";
		}


	}
}