﻿using System.Threading.Tasks;

namespace AppFunc
{
    public interface IAppDispatcher
    {
        TResponse Handle<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>;
        void Handle<TRequest>(TRequest request) where TRequest : IRequest;

        Task HandleAsync<TRequest>(TRequest request) where TRequest : IAsyncRequest;
        Task<TResponse> HandleAsync<TRequest, TResponse>(TRequest request) where TRequest : IAsyncRequest<TResponse>;
    }
}