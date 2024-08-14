using ShopManagementApp.Domain.Address;

namespace ShopManagementApp.Infrastructure.Contracts;

public partial interface IAddressRepository
{
    Task<Addresses> Get_Addresses_By_ADDRESSES_ID_Eager1To1(Params_Get_Addresses_By_ADDRESSES_ID i_Params_Get_Addresses_By_ADDRESSES_ID);
    Task<IEnumerable<Addresses>> Get_Addresses_By_ADDRESSES_ID_List_Eager1To1(Params_Get_Addresses_By_ADDRESSES_ID_List i_Params_Get_Addresses_By_ADDRESSES_ID_List);
    Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_Eager1To1(Params_Get_Addresses_By_CUSTOMERS_ID i_Params_Get_Addresses_By_CUSTOMERS_ID);
    Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_List_Eager1To1(Params_Get_Addresses_By_CUSTOMERS_ID_List i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
    Task<Get_Addresses_By_Properties_Response> Get_Addresses_By_Properties_Eager1To1(Params_Get_Addresses_By_Properties i_Params_Get_Addresses_By_Properties);
    Task<IEnumerable<Addresses>> Get_Addresses_By_TENANT_ID_Eager1To1(Params_Get_Addresses_By_TENANT_ID i_Params_Get_Addresses_By_TENANT_ID);
}
