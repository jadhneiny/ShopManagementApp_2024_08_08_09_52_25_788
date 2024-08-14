using ShopManagementApp.Domain.Order;

namespace ShopManagementApp.Application.Contracts;

public partial interface IOrderService
{
    Task<Order_details> Get_Order_details_By_ORDER_DETAILS_ID(Params_Get_Order_details_By_ORDER_DETAILS_ID i_Params_Get_Order_details_By_ORDER_DETAILS_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_ORDER_DETAILS_ID_List(Params_Get_Order_details_By_ORDER_DETAILS_ID_List i_Params_Get_Order_details_By_ORDER_DETAILS_ID_List);
    Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID(Params_Get_Order_details_By_ORDERS_ID i_Params_Get_Order_details_By_ORDERS_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_ORDERS_ID_List(Params_Get_Order_details_By_ORDERS_ID_List i_Params_Get_Order_details_By_ORDERS_ID_List);
    Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID(Params_Get_Order_details_By_PRODUCTS_ID i_Params_Get_Order_details_By_PRODUCTS_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_PRODUCTS_ID_List(Params_Get_Order_details_By_PRODUCTS_ID_List i_Params_Get_Order_details_By_PRODUCTS_ID_List);
    Task<Get_Order_details_By_Properties_Response> Get_Order_details_By_Properties(Params_Get_Order_details_By_Properties i_Params_Get_Order_details_By_Properties);
    Task<IEnumerable<Order_details>> Get_Order_details_By_TENANT_ID(Params_Get_Order_details_By_TENANT_ID i_Params_Get_Order_details_By_TENANT_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID(Params_Get_Order_details_By_TENANTS_ID i_Params_Get_Order_details_By_TENANTS_ID);
    Task<IEnumerable<Order_details>> Get_Order_details_By_TENANTS_ID_List(Params_Get_Order_details_By_TENANTS_ID_List i_Params_Get_Order_details_By_TENANTS_ID_List);
    Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID(Params_Get_Orders_By_CUSTOMERS_ID i_Params_Get_Orders_By_CUSTOMERS_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_CUSTOMERS_ID_List(Params_Get_Orders_By_CUSTOMERS_ID_List i_Params_Get_Orders_By_CUSTOMERS_ID_List);
    Task<Orders> Get_Orders_By_ORDERS_ID(Params_Get_Orders_By_ORDERS_ID i_Params_Get_Orders_By_ORDERS_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_ORDERS_ID_List(Params_Get_Orders_By_ORDERS_ID_List i_Params_Get_Orders_By_ORDERS_ID_List);
    Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID(Params_Get_Orders_By_PROMO_CODES_ID i_Params_Get_Orders_By_PROMO_CODES_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_PROMO_CODES_ID_List(Params_Get_Orders_By_PROMO_CODES_ID_List i_Params_Get_Orders_By_PROMO_CODES_ID_List);
    Task<Get_Orders_By_Properties_Response> Get_Orders_By_Properties(Params_Get_Orders_By_Properties i_Params_Get_Orders_By_Properties);
    Task<IEnumerable<Orders>> Get_Orders_By_TENANT_ID(Params_Get_Orders_By_TENANT_ID i_Params_Get_Orders_By_TENANT_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID(Params_Get_Orders_By_TENANTS_ID i_Params_Get_Orders_By_TENANTS_ID);
    Task<IEnumerable<Orders>> Get_Orders_By_TENANTS_ID_List(Params_Get_Orders_By_TENANTS_ID_List i_Params_Get_Orders_By_TENANTS_ID_List);
}