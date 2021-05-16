﻿using System;

namespace WorkflowCore.Persistence.RavenDB
{
	public class RavenStoreOptions
	{
		public string ServerUrl { get; set; }
		public string DatabaseName { get; set; }
		public string CertificatePath { get; set; }
		public string CertificatePassword { get; set; }
	}
}
