import React, { useState } from 'react';
import { Text, TextInput, TouchableOpacity, View } from "react-native";
import { FontAwesomeIcon } from '@fortawesome/react-native-fontawesome';
import {
    faEye,
    faEyeSlash
} from '@fortawesome/free-solid-svg-icons';

function Input({
    value,
    placeholder,
    handleChange,
    error,
    title,
    require,
    area,
    password
}) {
    const [hidden, setHidden] = useState(true)
    return (
        <View className="flex flex-col mt-1">
            <Text className='mb-2'>{title} {require ? <Text className='text-red-500'>*</Text> : ''}</Text>
            <View className='flex flex-row justify-center items-center gap-2'>
                <TextInput
                    className={error === '' || error === undefined ? "px-2 py-2 font-semibold text-base border flex-1 rounded-2xl" : "px-2 py-2 font-semibold text-base border border-red-500 flex-1 rounded-2xl"}
                    value={value}
                    placeholder={placeholder}
                    onChangeText={handleChange}
                    multiline={area}
                    secureTextEntry={password ? hidden : false}
                >
                </TextInput>
                {
                    password && (
                        hidden === true ? <TouchableOpacity onPress={() => setHidden(false)}>
                            <FontAwesomeIcon icon={faEye} />
                        </TouchableOpacity> : <TouchableOpacity onPress={() => setHidden(true)}>
                            <FontAwesomeIcon icon={faEyeSlash} />
                        </TouchableOpacity>

                    )
                }


            </View>

            {
                error === '' ? <Text></Text> : <Text className='text-red-500 mt-1'>{error}</Text>
            }
        </View>
    );
}

export default Input;