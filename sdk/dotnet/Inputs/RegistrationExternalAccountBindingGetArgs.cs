// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Acme.Inputs
{

    public sealed class RegistrationExternalAccountBindingGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("hmacBase64", required: true)]
        public Input<string> HmacBase64 { get; set; } = null!;

        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        public RegistrationExternalAccountBindingGetArgs()
        {
        }
        public static new RegistrationExternalAccountBindingGetArgs Empty => new RegistrationExternalAccountBindingGetArgs();
    }
}
