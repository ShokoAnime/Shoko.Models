
namespace Shoko.Models.Client;

public class CL_RenameScript
{
    public int RenameScriptID { get; set; }

    public string ScriptName { get; set; }

    public string Script { get; set; }

    public int IsEnabledOnImport { get; set; }

    public string RenamerType { get; set; }

    public string ExtraData { get; set; }
}
