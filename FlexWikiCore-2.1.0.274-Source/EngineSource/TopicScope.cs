#region License Statement
// Copyright (c) Microsoft Corporation.  All rights reserved.
//
// The use and distribution terms for this software are covered by the 
// Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file CPL.TXT at the root of this distribution.
// By using this software in any fashion, you are agreeing to be bound by 
// the terms of this license.
//
// You must not remove this notice, or any other, from this software.
#endregion

using System;
using System.Collections;

namespace FlexWiki
{
	/// <summary>
	/// 
	/// </summary>
	public class TopicScope : IScope
	{
    private IScope _ContainingScope;
    private DynamicTopic _Topic;

    public TopicScope(IScope ContainingScope, DynamicTopic topic)
		{
			_ContainingScope = ContainingScope;
			_Topic = topic;
		}

		
    public IScope ContainingScope
		{
			get
			{
				return _ContainingScope;
			}
		}

		public DynamicTopic Topic
		{
			get
			{
				return _Topic;
			}
		}

		public IBELObject ValueOf(string symbol, ArrayList args, ExecutionContext ctx)
		{
			return Topic.ValueOf(symbol, args, ctx);
		}
		
	}
}
