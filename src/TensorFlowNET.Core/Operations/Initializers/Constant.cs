﻿/*****************************************************************************
   Copyright 2018 The TensorFlow.NET Authors. All Rights Reserved.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
******************************************************************************/

namespace Tensorflow.Operations.Initializers
{
    public class Constant<T> : IInitializer
    {
        TF_DataType dtype;
        T value;
        bool _verify_shape;

        public Constant(T value, TF_DataType dtype = TF_DataType.TF_FLOAT, bool verify_shape = false)
        {
            this.value = value;
            this.dtype = dtype;
            _verify_shape = verify_shape;
        }

        public Tensor call(TensorShape shape, TF_DataType dtype = TF_DataType.DtInvalid, bool? verify_shape = null)
        {
            if (dtype == TF_DataType.DtInvalid)
                dtype = this.dtype;

            if (!verify_shape.HasValue)
                verify_shape = _verify_shape;

            return constant_op._constant_impl(value, dtype, shape,
                name: "Const",
                verify_shape: verify_shape.Value,
                allow_broadcast: false);
        }

        public object get_config()
        {
            return new
            {
                value,
                dtype = dtype.name()
            };
        }
    }
}
