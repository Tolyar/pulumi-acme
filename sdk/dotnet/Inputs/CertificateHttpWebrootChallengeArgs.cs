// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Acme.Inputs
{

    public sealed class CertificateHttpWebrootChallengeArgs : global::Pulumi.ResourceArgs
    {
        [Input("directory", required: true)]
        public Input<string> Directory { get; set; } = null!;

        public CertificateHttpWebrootChallengeArgs()
        {
        }
        public static new CertificateHttpWebrootChallengeArgs Empty => new CertificateHttpWebrootChallengeArgs();
    }
}
