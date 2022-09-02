using System;
using System.Linq.Expressions;

namespace AutoHost
{
    public static class Configurator
    {
        internal class ParameterConfigurator : IParameterConfigurator
        {
            public IParameterConfigurator Configure<TIn, TOut>(Expression<Func<TIn, TOut>> expression, params Attribute[] attribute)
            {
                return this;
            }
        }
    }

    public interface IParameterConfigurator
    {
        IParameterConfigurator Configure<TIn, TOut>(Expression<Func<TIn, TOut>> expression, params Attribute[] attribute);
    }
    public interface IMethodConfigurator
    {
        IParameterConfigurator Configure<TIn, TOut>(Expression<Func<TIn, TOut>> expression);
    }
    public interface IClassConfigurator
    {
        IMethodConfigurator Configure<TIn, TOut>(Expression<Func<TIn, TOut>> expression);
    }
}