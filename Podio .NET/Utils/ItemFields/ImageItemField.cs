﻿using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PodioAPI.Models;

namespace PodioAPI.Utils.ItemFields
{
    public class ImageItemField : ItemField
    {
        public IEnumerable<FileAttachment> Images
        {
            get { return this.ValuesAs<FileAttachment>(); }
        }

        public IEnumerable<int> FileIds
        {
            set
            {
                ensureValuesInitialized();
                foreach (var fileId in value)
                {
                    var jobject = new JObject();
                    jobject["value"] = fileId;
                    this.Values.Add(jobject);
                }
            }
        }

        public int FileId
        {
            set
            {
                ensureValuesInitialized();

                var jobject = new JObject();
                jobject["value"] = value;
                this.Values.Add(jobject);
            }
        }
    }
}