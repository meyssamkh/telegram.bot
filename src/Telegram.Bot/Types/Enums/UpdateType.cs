﻿using System.Runtime.Serialization;

namespace Telegram.Bot.Types.Enums
{
    /// <summary>
    /// The type of an Update
    /// </summary>
    public enum UpdateType
    {
        /// <summary>
        /// Update Type is unknown
        /// </summary>
        [EnumMember(Value = "unknown_update")]
        UnkownUpdate = 0,

        /// <summary>
        /// The <see cref="Update"/> contains a <see cref="Message"/>.
        /// </summary>
        [EnumMember(Value = "message_update")]
        MessageUpdate,

        /// <summary>
        /// The <see cref="Update"/> contains an <see cref="InlineQueryUpdate"/>.
        /// </summary>
        [EnumMember(Value = "inline_query_update")]
        InlineQueryUpdate,

        /// <summary>
        /// The <see cref="Update"/> contains a <see cref="ChosenInlineResultUpdate"/>.
        /// </summary>
        [EnumMember(Value = "chosen_inline_result_update")]
        ChosenInlineResultUpdate,

        /// <summary>
        /// The <see cref="Update"/> contins a <see cref="CallbackQueryUpdate"/>
        /// </summary>
        [EnumMember(Value = "callback_query_update")]
        CallbackQueryUpdate,

        /// <summary>
        /// The <see cref="Update"/> contains an edited <see cref="Message"/>
        /// </summary>
        [EnumMember(Value = "edited_message")]
        EditedMessage,
    }
}
