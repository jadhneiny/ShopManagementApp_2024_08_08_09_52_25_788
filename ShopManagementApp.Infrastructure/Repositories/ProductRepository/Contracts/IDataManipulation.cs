using ShopManagementApp.Domain.Product;

namespace ShopManagementApp.Infrastructure.Contracts;

public partial interface IProductRepository
{
    Task Delete_Products(Params_Delete_Products i_Params_Delete_Products);
    Task Delete_Products_By_SHOPS_ID(Params_Delete_Products_By_SHOPS_ID i_Params_Delete_Products_By_SHOPS_ID);
    Task Delete_Products_By_TENANT_ID(Params_Delete_Products_By_TENANT_ID i_Params_Delete_Products_By_TENANT_ID);
    Task Delete_Products_By_TENANTS_ID(Params_Delete_Products_By_TENANTS_ID i_Params_Delete_Products_By_TENANTS_ID);
    Task Edit_Products(Products i_Products);
    Task Delete_Shops(Params_Delete_Shops i_Params_Delete_Shops);
    Task Delete_Shops_By_TENANT_ID(Params_Delete_Shops_By_TENANT_ID i_Params_Delete_Shops_By_TENANT_ID);
    Task Delete_Shops_By_TENANTS_ID(Params_Delete_Shops_By_TENANTS_ID i_Params_Delete_Shops_By_TENANTS_ID);
    Task Edit_Shops(Shops i_Shops);
}