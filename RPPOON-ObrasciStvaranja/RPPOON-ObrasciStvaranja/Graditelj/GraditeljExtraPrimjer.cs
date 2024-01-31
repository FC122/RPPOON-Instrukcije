// namespace GEP{

// interface IPermission
// {
//     public void Allow();
// }
// public class EditPermission : IPermission
// {
//     public void Allow()
//     { Console.WriteLine("User Has Edit Permission"); }
// }
// public class DeletePermission : IPermission
// {
//     public void Allow()
//     { Console.WriteLine("User Has Delete Permission"); }
// }
// public class CreatePermission : IPermission
// {
//     public void Allow()
//     { Console.WriteLine("User Has Create Permission"); }
// }
// public class ViewPermission : IPermission
// {
//     public void Allow()
//     { Console.WriteLine("User Has View Permission"); }
// }
// public interface AccountConfigurator
// {
//     public void AddEditPermission(EditPermission permission);
//     public void AddDeletePermission(DeletePermission permission);
//     public void AddCreatePermission(CreatePermission permission);
//     public void AddViewPermission(ViewPermission permission);
//     public void ClearPermissions();
// }

// public class ConcreteAccountConfigurator:AccountConfigurator{
//     public Token token = new Token();

//      public void AddEditPermission(EditPermission permission){
//         token.permissions.Add(permission)
//      }
//     public void AddDeletePermission(DeletePermission permission){
//         token.permissions.Add(permission)

//     }
//     public void AddCreatePermission(CreatePermission permission){
//         token.permissions.Add(permission)

//     }
//     public void AddViewPermission(ViewPermission permission){
//         token.permissions.Add(permission)

//     }
//     public void ClearPermissions(){
//         token.permissions.Clear();
//     }

//     public Token Build(){
//         return token;
//     }
// }

// public class Token{
//     public List<IPermission>permission= new List<IPermission>();
// }

// public class PresetPermissions
// {
//     ConcreteAccountConfigurator ac = new ConcreteAccountConfigurator();
//     public Token Admin()
//     {
//         ac.AddCreatePermission(new CreatePermission());
//         ac.AddEditPermission(new EditPermission());
//         ac.AddDeletePermission(new DeletePermission());
//         ac.AddViewPermission(new ViewPermission());
//         return ac.Build();
//     }
//     public void User()
//     {
//         //give view permission
//     }
//     public void manager()
//     {
//         //give create edit view
//     }
// }
// }