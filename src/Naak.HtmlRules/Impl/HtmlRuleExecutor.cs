using System;
using System.Collections.Generic;
using System.Xml;

namespace Naak.HtmlRules.Impl
{
	public class HtmlRuleExecutor : IHtmlRuleExecutor
	{
		private readonly IServiceLocator _serviceLocator;
		private readonly IXmlDocumentBuilder _documentBuilder;
		private readonly IXmlNamespaceManagerBuilder _namespaceManagerBuilder;

		public HtmlRuleExecutor(IServiceLocator serviceLocator, IXmlDocumentBuilder documentBuilder,
		                        IXmlNamespaceManagerBuilder namespaceManagerBuilder)
		{
			_serviceLocator = serviceLocator;
			_documentBuilder = documentBuilder;
			_namespaceManagerBuilder = namespaceManagerBuilder;
		}

		public ValidationError[] GetAccessibilityErrors(string html)
		{
			var records = new List<ValidationError>();

			try
			{
				XmlDocument document = _documentBuilder.Build(html);
				XmlNamespaceManager namespaceManager = _namespaceManagerBuilder.Build(document);

				foreach (IHtmlRule htmlRule in _serviceLocator.CreateAllInstances<IHtmlRule>())
				{
					ValidationError[] currentRecords = htmlRule.ValidateHtml(document, namespaceManager);

					foreach (ValidationError record in currentRecords)
					{
						records.Add(record);
					}
				}
			}
			catch (Exception exc)
			{
				records.Add(new ValidationError(exc.Message));
			}

			return records.ToArray();
		}
	}
}