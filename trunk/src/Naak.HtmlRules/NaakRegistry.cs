using Naak.HtmlRules.Impl;
using StructureMap.Configuration.DSL;

namespace Naak.HtmlRules
{
	public class NaakRegistry : Registry
	{
		protected override void configure()
		{
			Scan(x =>
			     	{
			     		x.TheCallingAssembly();
			     		x.WithDefaultConventions();
			     	});

			ForRequestedType<IHtmlRule>().AddConcreteType<AtLeastOneH1>();
			ForRequestedType<IHtmlRule>().AddConcreteType<FormElementsHaveLabels>();
			ForRequestedType<IHtmlRule>().AddConcreteType<ImageInputsHaveAltText>();
			ForRequestedType<IHtmlRule>().AddConcreteType<TablesHaveColumnHeaders>();
			ForRequestedType<IHtmlRule>().AddConcreteType<FieldsetsHaveLegends>();
			ForRequestedType<IHtmlRule>().AddConcreteType<LabelsRelateToFormElements>();
			ForRequestedType<IHtmlRule>().AddConcreteType<ImagesHaveAltText>();
			ForRequestedType<IHtmlRule>().AddConcreteType<ImagesDontHaveDuplicateAltText>();
			ForRequestedType<IHtmlRule>().AddConcreteType<ContextOfLinkTextMustMakeSense>();
			ForRequestedType<IHtmlRule>().AddConcreteType<HeadingsAreLogicallyOrdered>();
		}
	}
}
