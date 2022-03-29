﻿using AltV.Net.Client.Elements.Entities;
using AltV.Net.Client.Elements.Interfaces;

namespace AltV.Net.Client.Elements.Pools
{
    public interface IEntityPool<TEntity> where TEntity : IEntity
    {
        void Create(ICore server, IntPtr entityPointer, ushort id);
        
        void Create(ICore server, IntPtr entityPointer, ushort id, out TEntity entity);
        
        void Create(ICore server, IntPtr entityPointer, out TEntity entity);

        void Add(TEntity entity);

        bool Remove(TEntity entity);

        bool Remove(ushort id);

        bool Get(ushort id, out TEntity entity);

        bool GetOrCreate(ICore server, IntPtr entityPointer, ushort entityId, out TEntity entity);
        bool GetOrCreate(ICore server, IntPtr entityPointer, out TEntity entity);

        ICollection<TEntity> GetAllEntities();

        KeyValuePair<ushort, TEntity>[] GetEntitiesArray();

        // void ForEach(IBaseObjectCallback<TEntity> baseObjectCallback);
        //
        // Task ForEach(IAsyncBaseObjectCallback<TEntity> asyncBaseObjectCallback);

        void OnAdd(TEntity entity);

        void OnRemove(TEntity entity);
        
        void Dispose();
    }
}