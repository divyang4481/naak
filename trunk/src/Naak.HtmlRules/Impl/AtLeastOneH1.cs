using System.Collections.Generic;
using System.Xml;

namespace Naak.HtmlRules.Impl
{
	public class AtLeastOneH1 : IHtmlRule
	{
		public ValidationError[] ValidateHtml(XmlDocument document, XmlNamespaceManager namespaceManager)
		{
			var records = new List<ValidationError>();

			XmlNodeList nodes = document.SelectNodes("//x:h1", namespaceManager);

			if (nodes.Count == 0)
			{
				records.Add(new ValidationError("There must be at least one H1 tag on the page"));
			}

			return records.ToArray();
		}
	}
}