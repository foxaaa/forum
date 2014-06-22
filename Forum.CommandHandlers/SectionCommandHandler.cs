﻿using ECommon.Components;
using ENode.Commanding;
using Forum.Commands.Sections;
using Forum.Domain;
using Forum.Domain.Sections;

namespace Forum.CommandHandlers
{
    [Component(LifeStyle.Singleton)]
    public class SectionCommandHandler :
        ICommandHandler<CreateSectionCommand>,
        ICommandHandler<UpdateSectionCommand>
    {
        private readonly AggregateRootFactory _factory;

        public SectionCommandHandler(AggregateRootFactory factory)
        {
            _factory = factory;
        }

        public void Handle(ICommandContext context, CreateSectionCommand command)
        {
            context.Add(_factory.CreateSection(command.Name));
        }
        public void Handle(ICommandContext context, UpdateSectionCommand command)
        {
            context.Get<Section>(command.AggregateRootId).Update(command.Name);
        }
    }
}
