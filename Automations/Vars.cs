namespace PythonSandbox;

public class Vars : PythonAutomation
{
    protected override Dependencies Dependencies => Dependencies.None;

	protected override void ApplyAutomation()
	{
		// Items contains all items / arguments passed into the automation
		foreach(Item item in Items) 
		{
			// Code added to CodeAfterAutomation will be generated right after the automation
			CodeAfterAutomation += @$"
{item} = if_contains(dictionary, '{item}')";
		}
	}
}