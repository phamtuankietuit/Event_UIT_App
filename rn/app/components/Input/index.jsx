import React, { useState } from "react"
import { Text, TextInput, TouchableOpacity, View } from "react-native"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faEye, faEyeSlash } from "@fortawesome/free-solid-svg-icons"

function Input({
  value,
  placeholder,
  handleChange,
  error,
  title,
  require,
  area,
  password,
}) {
  const [hidden, setHidden] = useState(true)
  return (
    <View className='mt-1 flex flex-col'>
      <Text className='mb-2 text-base'>
        {title} {require ? <Text className='text-red-500'>*</Text> : ""}
      </Text>
      <View className='flex flex-row items-center justify-center gap-2'>
        <TextInput
          className={
            error === "" || error === undefined
              ? "flex-1 rounded border px-2 py-2 text-base font-semibold"
              : "flex-1 rounded border border-red-500 px-2 py-2 text-base font-semibold"
          }
          value={value}
          placeholder={placeholder}
          onChangeText={handleChange}
          multiline={area}
          secureTextEntry={password ? hidden : false}
        ></TextInput>
        {password &&
          (hidden === true ? (
            <TouchableOpacity onPress={() => setHidden(false)}>
              <FontAwesomeIcon icon={faEye} color="#888"/>
            </TouchableOpacity>
          ) : (
            <TouchableOpacity onPress={() => setHidden(true)}>
              <FontAwesomeIcon icon={faEyeSlash} />
            </TouchableOpacity>
          ))}
      </View>

      {error === "" ? (
        <Text></Text>
      ) : (
        <Text className='mt-1 text-red-500'>{error}</Text>
      )}
    </View>
  )
}

export default Input
