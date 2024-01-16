
interface IPermission
{
    public void Allow();
}
public class EditPermission : IPermission
{
    public void Allow()
    { Console.WriteLine("User Has Edit Permission"); }
}
public class DeletePermission : IPermission
{
    public void Allow()
    { Console.WriteLine("User Has Delete Permission"); }
}
public class CreatePermission : IPermission
{
    public void Allow()
    { Console.WriteLine("User Has Create Permission"); }
}
public class ViewPermission : IPermission
{
    public void Allow()
    { Console.WriteLine("User Has View Permission"); }
}
public interface AccountConfigurator
{
    public void AddEditPermission(EditPermission permission);
    public void AddDeletePermission(DeletePermission permission);
    public void AddCreatePermission(CreatePermission permission);
    public void AddViewPermission(ViewPermission permission);
    public void ClearPermissions();
}
public class PresetPermissions
{
    public void Admin()
    {
        //give all permission
    }
    public void User()
    {
        //give view permission
    }
    public void manager()
    {
        //give create edit view
    }
}