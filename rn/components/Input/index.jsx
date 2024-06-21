import React from 'react';
import { Text, TextInput, View } from "react-native";

function Input({
    value,
    placeholder,
    handleChange,
    error,
    title,
    require,
    area
}) {
    return (
        <View className="flex flex-col mt-1">
            <Text className='mb-2'>{title} {require ? <Text className='text-red-500'>*</Text> : ''}</Text>
            <TextInput
                className={error === '' || error === undefined ? "px-2 py-2 font-semibold text-base border w-[100%] rounded-2xl" : "px-2 py-2 font-semibold text-base border border-red-500 w-[100%] rounded-2xl"}
                value={value}
                placeholder={placeholder}
                onChangeText={handleChange}
                multiline={area}
            >
            </TextInput>
            {
                error === '' ? <Text></Text> : <Text className='text-red-500 mt-1'>{error}</Text>
            }
        </View>
    );
}

export default Input;