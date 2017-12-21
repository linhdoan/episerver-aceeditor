﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EPiServer.Plugins.AceEditor.Editors
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = UIHints.Jsp,
        EditorDescriptorBehavior = EditorDescriptorBehavior.PlaceLast)]
    public class JspEditorDescriptor : AceEditorDescriptor
    {
    }
}