// Copyright 2007-2014 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Automatonymous.Behaviors
{
    using System.Threading.Tasks;


    public class EmptyBehavior<TInstance> :
        Behavior<TInstance>
    {
        void Visitable.Accept(StateMachineVisitor visitor)
        {
            visitor.Visit(this);
        }

        async Task Behavior<TInstance>.Execute(BehaviorContext<TInstance> context)
        {
        }

        async Task Behavior<TInstance>.Execute<T>(BehaviorContext<TInstance, T> context)
        {
        }
    }


    public class EmptyBehavior<TInstance, TData> :
        Behavior<TInstance, TData>
    {
        async Task Behavior<TInstance, TData>.Execute(BehaviorContext<TInstance, TData> context)
        {
        }

        void Visitable.Accept(StateMachineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}