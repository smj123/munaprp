﻿namespace nothinbutdotnetprep.infrastructure.filtering
{
    public static class Where<ItemToMatch>
    {
        public static PropertyAccessor<ItemToMatch, PropertyType> has_a<PropertyType>(
            PropertyAccessor<ItemToMatch, PropertyType> accessor)
        {
            return accessor;
        }
    }
}