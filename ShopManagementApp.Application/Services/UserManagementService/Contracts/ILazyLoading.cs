using ShopManagementApp.Domain.UserManagement;

namespace ShopManagementApp.Application.Contracts;

public partial interface IUserManagementService
{
    Task<Admins> Get_Admins_By_ADMINS_ID(Params_Get_Admins_By_ADMINS_ID i_Params_Get_Admins_By_ADMINS_ID);
    Task<IEnumerable<Admins>> Get_Admins_By_ADMINS_ID_List(Params_Get_Admins_By_ADMINS_ID_List i_Params_Get_Admins_By_ADMINS_ID_List);
    Task<Get_Admins_By_Properties_Response> Get_Admins_By_Properties(Params_Get_Admins_By_Properties i_Params_Get_Admins_By_Properties);
    Task<IEnumerable<Admins>> Get_Admins_By_TENANT_ID(Params_Get_Admins_By_TENANT_ID i_Params_Get_Admins_By_TENANT_ID);
    Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID(Params_Get_Admins_By_TENANTS_ID i_Params_Get_Admins_By_TENANTS_ID);
    Task<IEnumerable<Admins>> Get_Admins_By_TENANTS_ID_List(Params_Get_Admins_By_TENANTS_ID_List i_Params_Get_Admins_By_TENANTS_ID_List);
    Task<Customers> Get_Customers_By_CUSTOMERS_ID(Params_Get_Customers_By_CUSTOMERS_ID i_Params_Get_Customers_By_CUSTOMERS_ID);
    Task<IEnumerable<Customers>> Get_Customers_By_CUSTOMERS_ID_List(Params_Get_Customers_By_CUSTOMERS_ID_List i_Params_Get_Customers_By_CUSTOMERS_ID_List);
    Task<Get_Customers_By_Properties_Response> Get_Customers_By_Properties(Params_Get_Customers_By_Properties i_Params_Get_Customers_By_Properties);
    Task<IEnumerable<Customers>> Get_Customers_By_TENANT_ID(Params_Get_Customers_By_TENANT_ID i_Params_Get_Customers_By_TENANT_ID);
    Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID(Params_Get_Customers_By_TENANTS_ID i_Params_Get_Customers_By_TENANTS_ID);
    Task<IEnumerable<Customers>> Get_Customers_By_TENANTS_ID_List(Params_Get_Customers_By_TENANTS_ID_List i_Params_Get_Customers_By_TENANTS_ID_List);
}
