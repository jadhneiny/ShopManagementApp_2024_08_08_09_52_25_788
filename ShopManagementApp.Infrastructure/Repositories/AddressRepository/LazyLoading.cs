using System.Data;
using Microsoft.Extensions.Logging;
using ShopManagementApp.Domain.Address;
using ShopManagementApp.Infrastructure.Entities;

namespace ShopManagementApp.Infrastructure.Repositories;

public partial class AddressRepository
{
    public async Task<Addresses> Get_Addresses_By_ADDRESSES_ID(Params_Get_Addresses_By_ADDRESSES_ID i_Params_Get_Addresses_By_ADDRESSES_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_ADDRESSES_ID);
            var oAddresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.QuerySingle, "UP_GET_ADDRESSES_BY_ADDRESSES_ID", _params).ConfigureAwait(false);

            if (oAddresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_ADDRESSES_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_ADDRESSES_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            }

            return oAddresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_ADDRESSES_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_ADDRESSES_ID_List(Params_Get_Addresses_By_ADDRESSES_ID_List i_Params_Get_Addresses_By_ADDRESSES_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_ADDRESSES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_ADDRESSES_ID_LIST", _params).ConfigureAwait(false);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_ADDRESSES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_ADDRESSES_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_ADDRESSES_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_ADDRESSES_ID_List);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID(Params_Get_Addresses_By_CUSTOMERS_ID i_Params_Get_Addresses_By_CUSTOMERS_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_CUSTOMERS_ID);
            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_CUSTOMERS_ID", _params).ConfigureAwait(false);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_CUSTOMERS_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_CUSTOMERS_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_CUSTOMERS_ID_List(Params_Get_Addresses_By_CUSTOMERS_ID_List i_Params_Get_Addresses_By_CUSTOMERS_ID_List)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_CUSTOMERS_ID_LIST", _params).ConfigureAwait(false);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_CUSTOMERS_ID_List operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_CUSTOMERS_ID_List operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_CUSTOMERS_ID_List);
            throw;
        }
    }

    public async Task<Get_Addresses_By_Properties_Response> Get_Addresses_By_Properties(Params_Get_Addresses_By_Properties i_Params_Get_Addresses_By_Properties)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_Properties);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_Properties);
            _params.Add("TOTAL_COUNT", dbType: DbType.Int32, direction: ParameterDirection.Output);

            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_PROPERTIES", _params).ConfigureAwait(false);
            var oTotalCount = _params.Get<int>("TOTAL_COUNT");

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. Data Found. Total Count: {TotalCount}.", i_Params_Get_Addresses_By_Properties, oTotalCount);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_Properties operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_Properties);
            }

            return new()
            {
                List_Addresses = oList_Addresses,
                TOTAL_COUNT = oTotalCount
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_Properties operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_Properties);
            throw;
        }
    }

    public async Task<IEnumerable<Addresses>> Get_Addresses_By_TENANT_ID(Params_Get_Addresses_By_TENANT_ID i_Params_Get_Addresses_By_TENANT_ID)
    {
        try
        {
            _logger.LogInformation("Initiating Get_Addresses_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_TENANT_ID);

            var _params = new ExtendedDynamicParameters(i_Params_Get_Addresses_By_TENANT_ID);
            var oList_Addresses = await _databaseContext.Execute<Addresses>(Enum_Operation_Type.Query, "UP_GET_ADDRESSES_BY_TENANT_ID", _params).ConfigureAwait(false);

            if (oList_Addresses != null)
            {
                _logger.LogInformation("Get_Addresses_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. Data Found.", i_Params_Get_Addresses_By_TENANT_ID);
            }
            else
            {
                _logger.LogWarning("Get_Addresses_By_TENANT_ID operation at the repository layer completed successfully with parameters: {@Params}. No Data Found.", i_Params_Get_Addresses_By_TENANT_ID);
            }

            return oList_Addresses;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred during Get_Addresses_By_TENANT_ID operation at the repository layer with parameters: {@Params}.", i_Params_Get_Addresses_By_TENANT_ID);
            throw;
        }
    }
}
