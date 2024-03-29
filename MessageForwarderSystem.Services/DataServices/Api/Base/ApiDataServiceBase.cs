﻿namespace MessageForwarderSystem.Services.DataServices.Api.Base;

public abstract class ApiDataServiceBase<TEntity> : IDataServiceBase<TEntity> 
    where TEntity : BaseModel, new()
{
    protected readonly IApiServiceWrapperBase<TEntity> ServiceWrapper;

    protected ApiDataServiceBase(IApiServiceWrapperBase<TEntity> serviceWrapperBase)
    {
        ServiceWrapper = serviceWrapperBase;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => await ServiceWrapper.GetAllEntitiesAsync();

    public async Task<TEntity> FindAsync(int id)
        => await ServiceWrapper.GetEntityAsync(id);

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        await ServiceWrapper.UpdateEntityAsync(entity);
        return entity;
    }

    public async Task DeleteAsync(TEntity entity)
        => await ServiceWrapper.DeleteEntityAsync(entity);

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await ServiceWrapper.AddEntityAsync(entity);
        return entity;
    }
}